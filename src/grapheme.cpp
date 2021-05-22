#include "grapheme.h"

grapheme::~grapheme()
{
}

grapheme::grapheme(unsigned int RR, unsigned int CC)
{
  n_rows = RR;
  n_cols = CC;
  for (unsigned int j = 0; j < CC; j ++){
    Vec b;
    for (unsigned int i = 0; i < RR; i ++){
      b.push_back(false);
    }
    g.push_back(b);
  }
}

size_t grapheme::nrows()
{
  return n_rows;
}

size_t grapheme::ncols()
{
  return n_cols;
}

void grapheme::set(int y, int x, bool b)
{
g[y][x] =  b;
}

bool grapheme::get(int y ,int x)
{
return g[y][x];
}

//randomize the matrix
void grapheme::randomize(int p){
  for (unsigned int j = 0; j < g.size(); j ++){
    for (unsigned int i = 0; i < g[0].size(); i ++){
      g[j][i] =  rand()%100 < p;
    }
  }
}

//print as bool matrix
void grapheme::printb()
{
  cout << "size::"  << g.size() << std::endl;
  for (unsigned int j = 0; j < g.size(); j ++){
    for (unsigned int i = 0; i < g[0].size(); i ++){
      if (g[j][i]){
        std::cout << "#";
      }else{
        std::cout << " ";
      }

    }
    std::cout << std::endl;
  }
}
