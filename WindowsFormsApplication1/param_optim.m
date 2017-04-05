for count= 1:5
for cut_off = 1:16
for fillprobability =1:100
command = sprintf('cave_maker.exe 16 16 %d %d %d %d 123',fillprobability, cut_off,cut_off,count);
[status,cmdout]=system(command);
letter_analysis();    
fpath = 'C:\Users\sunny\Documents\cave_maker\paramopti'
saveas(gca,fullfile(fpath,sprintf('Figure%02d%02d%d.png',count,cut_off,fillprobability)));
end
end
end