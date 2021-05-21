#ifndef LET_H_
#define LET_H_
#include "base.h"
using namespace std;

class grapheme
{
	public:
		typedef vector<bool> Vec;
    typedef vector<Vec> Mat;

    Mat g;

		//destructor
		~grapheme();

		grapheme();

		grapheme(const Mat in);

		//copy constructor
		grapheme(const grapheme& g);


		//copy assignment constructor
		grapheme& operator=(const grapheme& g);

		//getters
		bool operator()(unsigned int x,unsigned int y) const;

		bool get(unsigned int x, unsigned int y) const;

		//setters
		void set(unsigned int x, unsigned int y, bool v);

		//print as bool matrix
		void printb();

    //flip the bit at the index
    void flip(unsigned int x, unsigned int y);

};
#endif
