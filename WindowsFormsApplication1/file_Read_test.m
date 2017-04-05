
%A{1}=imread('File001.bmp');
for i = 001:130   
    if i <10 
    filename = sprintf('File00%d.bmp', i)
    A{i} = imread(filename);
    elseif i <100 
    filename = sprintf('File0%d.bmp', i)
    A{i} = imread(filename);
    else 
    filename = sprintf('File%d.bmp', i)
    A{i} = imread(filename);
    end
end
