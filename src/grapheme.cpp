#include "grapheme.h"

grapheme::~grapheme()
{
  g.clear();
  g.shrink_to_fit();
}

grapheme::grapheme()
{
  Mat g;
}

//copy constructor
grapheme::grapheme(const grapheme& _g)
{
  g = _g.g;
}

//copy assignment constructor
grapheme& grapheme::operator=(const grapheme& _g)
{
  g = _g.g;
  return *this;
}

//getters
bool grapheme::operator()(unsigned int x,unsigned int y) const
{
  return g[y][x];
}

bool grapheme::get(unsigned int x, unsigned int y) const
{
  return g[y][x];
}

//setters
void grapheme::set(unsigned int x, unsigned int y, bool v)
{
  g[y][x] = v;
}

//print as bool matrix
void grapheme::printb()
{
  for (unsigned int i = 0; i < g.size(); i ++){
    for (unsigned int j = 0; j < g[0].size(); j ++){
      if (g[i][j]){
        std::cout << "#";
      }else{
        std::cout << " ";
      }
    }
  }
}

//flip the bit at the index
void grapheme::flip(unsigned int x, unsigned int y)
{
  g[y][x] = !g[y][x];
}
