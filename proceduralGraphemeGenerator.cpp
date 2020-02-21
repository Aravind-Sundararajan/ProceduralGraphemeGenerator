#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string>
#include "EasyBMP.h"
#include <iostream>
#include <cstdlib>
#define EMPTY_SPACE 0
#define FILLED_SPACE 1
using namespace std;
using std:: string;
//r1 and r2 cutoffs are used for the logic on deciding if we should keep EMPTY_SPACE in the future generation grid.
int r1_cutoff; //the number of tiles within r1_level step of this tile should be greater than R1_cutoff 
int r2_cutoff; //the number of tiles at r2_level steps of this tile should be less than R2_cutoff
int r1_cutoff_level; //the number of tiles away that we should count filled spaces to compare to r1_cutoff
int r2_cutoff_level; //the number of tiles away that we should count filled spaces to compare to r2_cutoff
/*
if count_r1 >= r1_cutoff || count_r2 <= r2_cutoff
then make R an FILLED_SPACE!
░░░░2
░▓▓1░
░▓R▓░
░▓▓▓░
░░░░░
*/
int generations;                     //the number of graphemes we should make
int seedNumber;                     //the starting seed we use when seeding the grid
int **grid;                         //init this generation grid
int **grid2;                        //init future generation grid
int fillProbability;                //percentage of the grid that we fill on initial seed before running the cellular automata
int size_x = 16, size_y = 16;       //initial size of the grid
int nGraphemes =1;                   //counter for the generations
char filename[sizeof "File100.bmp"];// preallocate the filename size
char runz[sizeof "potrace.exe --svg File100.bmp"]; //we're going to shellexec potrace to make svgs, so preallocate the length of the shellexec string

int randpick(void) //convenience method that we use to fill the grids with 0s or 1s
{
if(rand()%100 < fillProbability){
	return FILLED_SPACE;
}
else{
	return EMPTY_SPACE;
}
}

void initmap(void) //initialize our map to the specified size 
{
int xIndex, yIndex;
grid  = (int**)malloc(sizeof(int*) * size_y); //grid has size_y rows
grid2 = (int**)malloc(sizeof(int*) * size_y);

for(yIndex=0; yIndex<size_y; yIndex++)
{
	grid [yIndex] = (int*)malloc(sizeof(int) * size_x); //grid has size_x columns
	grid2[yIndex] = (int*)malloc(sizeof(int) * size_x);
}

for(yIndex=1; yIndex<size_y-1; yIndex++)
{
for(xIndex=1; xIndex<size_x-1; xIndex++)
{
	grid[yIndex][xIndex] = randpick();
}
}

for(yIndex=0; yIndex<size_y; yIndex++)
{
for(xIndex=0; xIndex<size_x; xIndex++)
{
	grid2[yIndex][xIndex] = FILLED_SPACE;
}
}

for(yIndex=0; yIndex<size_y; yIndex++)
{
	grid[yIndex][0] = grid[yIndex][size_x-1] = FILLED_SPACE;
}
for(xIndex=0; xIndex<size_x; xIndex++)
{
	grid[0][xIndex] = grid[size_y-1][xIndex] = FILLED_SPACE;
}

}

 void generation(void)
 {
	int xIndex;
	int yIndex;
	int	xCutoffIndex;
	int	yCutoffIndex;
 
	for(yIndex=1; yIndex<size_y-1; yIndex++)
	{
	for(xIndex=1; xIndex<size_x-1; xIndex++)
 	{
 		int adjcount_r1 = 0,
 		    adjcount_r2 = 0;
		
 		for(yCutoffIndex=yIndex-r1_cutoff_level; yCutoffIndex<=yIndex+r1_cutoff_level; yCutoffIndex++)
 		{
		for(xCutoffIndex=xIndex-r1_cutoff_level; xCutoffIndex<=xIndex+r1_cutoff_level; xCutoffIndex++)
 		{
			if(yCutoffIndex<0 || xCutoffIndex<0 || yCutoffIndex>=size_y || xCutoffIndex>=size_x)
 				continue;
 			if(grid[yCutoffIndex][xCutoffIndex] != EMPTY_SPACE)
 				adjcount_r1++;
 		}
		}
		
 		for(yCutoffIndex=yIndex-r2_cutoff_level; yCutoffIndex<=yIndex+r2_cutoff_level; yCutoffIndex++)
		{
 		for(xCutoffIndex=xIndex-r2_cutoff_level; xCutoffIndex<=xIndex+r2_cutoff_level; xCutoffIndex++)
 		{
 			if(abs(yCutoffIndex-yIndex)==r2_cutoff_level && abs(xCutoffIndex-xIndex)==r2_cutoff_level)
 				continue;
 			if(yCutoffIndex<0 || xCutoffIndex<0 || yCutoffIndex>=size_y || xCutoffIndex>=size_x)
 				continue;
 			if(grid[yCutoffIndex][xCutoffIndex] != EMPTY_SPACE)
 				adjcount_r2++;
 		}
		}
		
 		if(adjcount_r1 >= r1_cutoff || adjcount_r2 <= r2_cutoff)
 			grid2[yIndex][xIndex] = FILLED_SPACE;
 		else
 			grid2[yIndex][xIndex] = EMPTY_SPACE;
 	}
	}
 	for(yIndex=1; yIndex<size_y-1; yIndex++)
 	for(xIndex=1; xIndex<size_x-1; xIndex++)
 		grid[yIndex][xIndex] = grid2[yIndex][xIndex];
 }

void printmap(void)
{
BMP AnImage;
AnImage.SetSize(size_x,size_y);
AnImage.SetBitDepth(32);
int xIndex, yIndex;
for(yIndex=0; yIndex<size_y; yIndex++)
{
	for(xIndex=0; xIndex<size_x; xIndex++)
	{
		switch(grid[yIndex][xIndex]){
			
			case EMPTY_SPACE:
 				AnImage(xIndex,yIndex)->Red   = 0;
				AnImage(xIndex,yIndex)->Green = 0;
				AnImage(xIndex,yIndex)->Blue  = 0;
				AnImage(xIndex,yIndex)->Alpha = 0; break;
			
			//case FILLED_SPACE:  putchar('#'); break;
 			//case EMPTY_SPACE: putchar('.'); break;
		}
	}
	//putchar('\n');
}
sprintf(filename,"File%03d.bmp",nGraphemes);
AnImage.WriteToFile(filename);
}

int main(int argc, char **argv)
{
int thisGeneration;
if(argc < 9) {
	printf("Usage: %s xsize ysize fillProb r1 r1_level r2  r2_level nGenerations seed+\n", argv[0]);
	return 1;
}
size_x            = atoi(argv[1]);
size_y            = atoi(argv[2]);
fillProbability   = atoi(argv[3]);
r1_cutoff_level   = atoi(argv[4]);
r1_cutoff         = atoi(argv[5]);
r2_cutoff_level   = atoi(argv[6]);
r2_cutoff         = atoi(argv[7]);
generations       = atoi(argv[8]);
seedNumber        = atoi(argv[9]);
while (nGraphemes <100){
	srand(seedNumber); //seedrandom the input seed
	initmap();
	for(thisGeneration=0; thisGeneration<generations; thisGeneration++){
		generation();
		srand(seedNumber);
	}
	printmap();
	sprintf(runz,"potrace --svg File%03d.bmp",nGraphemes);
	nGraphemes++;
	seedNumber++;
	system(runz);
}
return seedNumber;
}
