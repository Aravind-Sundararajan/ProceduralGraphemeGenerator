clear all;
for x = 1:7
 filename = sprintf('File%d.bmp', x)
    A{x} = imread(filename);
end
TOt(16,16)=0;
a1 = A{1};
y=a1(:,:,3);
y(1,1);

for x = 1:7
a1=A{x};
y=a1(:,:,3);
for j = 1:16
    for k = 1:16
        an = y(k,j);
        if an==0
            TOt(k,j)=TOt(k,j)+1;
        end
    end
end

end
HeatMap(TOt);