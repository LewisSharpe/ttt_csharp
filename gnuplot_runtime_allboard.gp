set terminal pdf enhanced
set output 'runtime_allboard_prunecomp_210720.pdf'

set style data histogram
set style histogram cluster gap 1

set title 'Run time comparison for first move between pruning on and off on 4 cores'
set xlabel 'program variant'
set ylabel 'run time (seconds)'
set style fill solid border rgb "black"
set auto x
set yrange [0:*]
plot 'prune_time.dat' using 2:xtic(1) title col, \
        '' using 3:xtic(1) title col, \
        '' using 4:xtic(1) title col, \
        '' using 5:xtic(1) title col, \
        '' using 6:xtic(1) title col, \
        '' using 7:xtic(1) title col
