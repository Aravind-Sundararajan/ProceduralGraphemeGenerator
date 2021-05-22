#ifndef LET_H_
#define LET_H_
#include "base.h"
using namespace std;

class grapheme
{


	public:
		typedef vector<bool> Vec;
    typedef vector<Vec> Mat;

		//destructor
		~grapheme();

		grapheme(unsigned int RR, unsigned int CC);

    void set(int y, int x, bool b);

    bool get(int y, int x);

    void randomize(int p);

    size_t nrows();

    size_t ncols();

    //print as bool matrix
		void printb();

  private:
    Mat g;
    size_t n_rows;
    size_t n_cols;

};
#endif
