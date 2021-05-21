#ifndef GEN_H_
#define GEN_H_
#include "base.h"
#include "grapheme.h"
using namespace std;

class generator
{

public:
	//destructor
	~generator();

	generator();

  //size constructor
	generator(std::size_t s);

	//copy constructor
	generator(const generator& c);

  grapheme generate(const grapheme& g);

};
#endif
