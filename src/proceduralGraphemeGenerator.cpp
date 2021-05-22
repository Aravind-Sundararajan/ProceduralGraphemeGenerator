#include "base.h"
#include "grapheme.h"
#include "generator.h"
using namespace std::chrono;

using namespace std;
int main(int argc, char **argv)
{

  if (argc < 7){
    std::cout << "usage: x y fill r1 r2 iterations" << std::endl;
    return 1;
  }else{
    int size_x     = atoi(argv[1]);
    int size_y     = atoi(argv[2]);
    int fillprob   = atoi(argv[3]);
    int r1_cutoff = atoi(argv[4]);
    int r2_cutoff = atoi(argv[5]);
    int iterations = atoi(argv[6]);
    srand(time(NULL));

    grapheme gr(size_y,size_x);

    //gr.printb();
    int nGraphemes = 0;
    generator h;

    iterations = iterations % 10;
    char runz[sizeof "potrace.exe --svg File100.bmp"]; //we're going to shellexec potrace to make svgs, so preallocate the length of the shellexec string (this is perhaps unsafe and bad)
    while (nGraphemes <100){
      gr.randomize(fillprob);
      int i = 0;
      while (i < iterations){
        h.generate(gr,r1_cutoff,r2_cutoff);
        //std::cout << "ITERATION:" << i << std::endl;
        //gr.printb();
        i++;
      }
      nGraphemes++;
      h.printmap(gr,nGraphemes);
      sprintf(runz,"potrace --svg File%03d.bmp",nGraphemes);
      system(runz);
    }
  }
  return 0;
}
