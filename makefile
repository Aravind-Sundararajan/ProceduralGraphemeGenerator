CC = g++
CFLAGS = -g -Wall
INCLUDES = -I ./src/ -I lib -I /usr/local/include
srcdir := ./src/
bindir := ./bin/
base.o: $(srcdir)base.h
	$(CC) $(CFLAGS) $(INCLUDES) -c $(srcdir)base.cpp -o $(bindir)base.o
grapheme.o: $(srcdir)grapheme.h
	$(CC) $(CFLAGS) $(INCLUDES) -c $(srcdir)grapheme.cpp -o $(bindir)grapheme.o
generator.o: $(srcdir)generator.h
	$(CC) $(CFLAGS) $(INCLUDES) -c $(srcdir)generator.cpp -o $(bindir)generator.o
pgg.o: $(srcdir)proceduralGraphemeGenerator.cpp
	$(CC) $(CFLAGS) $(INCLUDES) -c $(srcdir)proceduralGraphemeGenerator.cpp -o $(bindir)pgg.o
test: base.o grapheme.o generator.o pgg.o
	$(CC) $(CFLAGS) $(INCLUDES) -o test $(bindir)base.o $(bindir)grapheme.o $(bindir)generator.o $(bindir)pgg.o
clean:
	rm -f *.exe test && cd $(bindir) && rm -f *.o
all: test
