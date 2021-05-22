#ifndef GEN_H_
#define GEN_H_
#include "base.h"
#include "grapheme.h"
#include "EasyBMP.h"
using namespace std;

class generator
{

public:
	//destructor
	~generator();

  //constructor
	generator();

	//copy constructor
	generator(const generator& c);

  void printmap(grapheme& g, int n);

  void generate(grapheme& g) const;

  void generate(grapheme& g, int r1_cutoff, int r2_cutoff) const;

};
#endif
