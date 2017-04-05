#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string>
#include "EasyBMP.h"
#include <iostream>
#include <cstdlib>
#define MAX_DATE 12
#define TILE_FLOOR 0
#define TILE_WALL 1
using namespace std;
using std:: string;
 	int r1_cutoff, r2_cutoff;
 	int reps;
 	int seed1;
 int **grid;
 int **grid2;
 int fillprob;
 int size_x = 16, size_y = 16;
 int repetitor =1;
 char filename[sizeof "File100.bmp"];
char runz[sizeof "potrace.exe --svg File100.bmp"];
 int randpick(void)
 {
 	if(rand()%100 < fillprob)
    {
        return TILE_WALL;
    }
 	else
    {
 		return TILE_FLOOR;
    }
 }

 void initmap(void)
 {
	int xi, yi;

	grid  = (int**)malloc(sizeof(int*) * size_y);
	grid2 = (int**)malloc(sizeof(int*) * size_y);

	for(yi=0; yi<size_y; yi++)
	{
		grid [yi] = (int*)malloc(sizeof(int) * size_x);
		grid2[yi] = (int*)malloc(sizeof(int) * size_x);
	}

	for(yi=1; yi<size_y-1; yi++)
	for(xi=1; xi<size_x-1; xi++)
		grid[yi][xi] = randpick();

	for(yi=0; yi<size_y; yi++)
	for(xi=0; xi<size_x; xi++)
		grid2[yi][xi] = TILE_WALL;

	for(yi=0; yi<size_y; yi++)
		grid[yi][0] = grid[yi][size_x-1] = TILE_WALL;
	for(xi=0; xi<size_x; xi++)
		grid[0][xi] = grid[size_y-1][xi] = TILE_WALL;
 }

 void generation(void)
 {
	int xi, yi, ii, jj;

	for(yi=1; yi<size_y-1; yi++)
	for(xi=1; xi<size_x-1; xi++)
 	{
 		int adjcount_r1 = 0,
 		    adjcount_r2 = 0;

 		for(ii=-1; ii<=1; ii++)
		for(jj=-1; jj<=1; jj++)
 		{
 			if(grid[yi+ii][xi+jj] != TILE_FLOOR)
 				adjcount_r1++;
 		}
 		for(ii=yi-2; ii<=yi+2; ii++)
 		for(jj=xi-2; jj<=xi+2; jj++)
 		{
 			if(abs(ii-yi)==2 && abs(jj-xi)==2)
 				continue;
 			if(ii<0 || jj<0 || ii>=size_y || jj>=size_x)
 				continue;
 			if(grid[ii][jj] != TILE_FLOOR)
 				adjcount_r2++;
 		}
 		if(adjcount_r1 >= r1_cutoff || adjcount_r2 <= r2_cutoff)
 			grid2[yi][xi] = TILE_WALL;
 		else
 			grid2[yi][xi] = TILE_FLOOR;
 	}
 	for(yi=1; yi<size_y-1; yi++)
 	for(xi=1; xi<size_x-1; xi++)
 		grid[yi][xi] = grid2[yi][xi];



 }

 void printmap(void)
 {
     BMP AnImage;

    AnImage.SetSize(size_x,size_y);

    AnImage.SetBitDepth(32);


 	int xi, yi;

 	for(yi=0; yi<size_y; yi++)
 	{
 		for(xi=0; xi<size_x; xi++)
 		{
 			switch(grid[yi][xi]) {
 				//case TILE_WALL:  putchar(178); break;
 				case TILE_FLOOR: //putchar(176);
 				AnImage(xi,yi)->Red = 0;
                AnImage(xi,yi)->Green = 0;
                AnImage(xi,yi)->Blue = 0;
                AnImage(xi,yi)->Alpha = 0; break;
 			}
 		}
 		//putchar('\n');
 	}
 	sprintf(filename,"File%03d.bmp",repetitor);

    AnImage.WriteToFile(filename);


 }

 int main(int argc, char **argv)
 {
 	int jj;

 	if(argc < 7) {
 		printf("Usage: %s xsize ysize fill (r1 r2 count) seed+\n", argv[0]);
 		return 1;
 	}
 	size_x     = atoi(argv[1]);
 	size_y     = atoi(argv[2]);
 	fillprob   = atoi(argv[3]);
    r1_cutoff  = atoi(argv[4]);
    r2_cutoff  = atoi(argv[5]);
    reps = atoi(argv[6]);
    seed1 = atoi(argv[7]);


while (repetitor <100){
     srand(seed1);
     initmap();
for(jj=0; jj<reps; jj++)
{
    generation();
    srand(seed1);
}



 	//putchar('\n');
 	printmap();
 sprintf(runz,"potrace --svg File%03d.bmp",repetitor);
    repetitor++;
    seed1++;

system(runz);
     }
 	return seed1;
 }
