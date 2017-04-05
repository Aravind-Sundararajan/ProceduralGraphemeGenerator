clear all;
sound{1,1} = '';
sound = importdata('sound_list.txt');
vowels = {'/&/'; '/(@)/'; '/A/'; '/eI/'; '/@/'; '/-/'; '/b/'; '/tS/'; '/d/'; '/E/'; '/i/'; '/f/'; '/g/';  '/h/'; '/hw/'; '/I/'; '/aI/'; '/dZ/'; '/k/'; '/l/'; '/m/'; '/N/'; '/n/'; '/Oi/'; '/A/'; '/AU/'; '/O/'; '/oU/'; '/u/'; '/U/'; '/p/'; '/r/'; '/S/'; '/s/'; '/T/'; '/D/'; '/t/'; '/@/'; '/@r/'; '/v/'; '/w/'; '/j/'; '/Z/'; '/z/'};
vowels2 ={'/,&/';'/,(@)/';'/,A/';'/,eI/';'/,@/';'/,-/';'/,b/';'/,tS/';'/,d/';'/,E/';'/,i/';'/,f/';'/,g/'; '/,h/';'/,hw/';'/,I/';'/,aI/';'/,dZ/';'/,k/';'/,l/';'/,m/';'/,N/';'/,n/';'/,Oi/';'/,A/';'/,AU/';'/,O/';'/,oU/';'/,u/';'/,U/';'/,p/';'/,r/';'/,S/';'/,s/';'/,T/';'/,D/';'/,t/';'/,@/';'/,@r/';'/,v/';'/,w/';'/,j/';'/,Z/';'/,z/'};
vowels3={'/''&/';'/''(@)/';'/''A/';'/''eI/';'/''@/';'/''-/';'/''b/';'/''tS/';'/''d/';'/''E/';'/''i/';'/''f/';'/''g/'; '/''h/';'/''hw/';'/''I/';'/''aI/';'/''dZ/';'/''k/';'/''l/';'/''m/';'/''N/';'/''n/';'/''Oi/';'/''A/';'/''AU/';'/''O/';'/''oU/';'/''u/';'/''U/';'/''p/';'/''r/';'/''S/';'/''s/';'/''T/';'/''D/';'/''t/';'/"@/';'/''@r/';'/''v/';'/''w/';'/''j/';'/''Z/';'/''z/'};
vowels4 = {'/_&/';'/_(@)/';'/_A/';'/_eI/';'/_@/';'/_-/';'/_b/';'/_tS/';'/_d/';'/_E/';'/_i/';'/_f/';'/_g/'; '/_h/';'/_hw/';'/_I/';'/_aI/';'/_dZ/';'/_k/';'/_l/';'/_m/';'/_N/';'/_n/';'/_Oi/';'/_A/';'/_AU/';'/_O/';'/_oU/';'/_u/';'/_U/';'/_p/';'/_r/';'/_S/';'/_s/';'/_T/';'/_D/';'/_t/';'/_@/';'/_@r/';'/_v/';'/_w/';'/_j/';'/_Z/';'/_z/'};

for i = 1:size(vowels)
    for x = 1:size(sound)    
    vowelcheck{i,x}=sum(~arrayfun(@isempty, regexp(sound{x}, vowels{i})));
    vowelcheck2{i,x}=sum(~arrayfun(@isempty, regexp(sound{x}, vowels2{i})));
    vowelcheck3{i,x}=sum(~arrayfun(@isempty, regexp(sound{x}, vowels3{i})));
    vowelcheck4{i,x}=sum(~arrayfun(@isempty, regexp(sound{x}, vowels4{i})));
    %fprintf('%s appears %d times in %s \n', char(vowels{i}),N,char(sound{x}));
    end
end
vowtotal = sum(cell2mat(vowelcheck),2) + sum(cell2mat(vowelcheck2),2) + sum(cell2mat(vowelcheck3),2) + sum(cell2mat(vowelcheck4),2);






h1 = figure;
bar(vowtotal/sum(vowtotal));
set(gca, 'XTickLabel',vowels, 'XTick',1:numel(vowels));
