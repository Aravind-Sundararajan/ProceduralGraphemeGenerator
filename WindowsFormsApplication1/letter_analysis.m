clearvars A a1 an ans filename i j k T_1 T_Avg TOt Tt x y;
for i = 1:88
 
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

TOt(16,16)=0;
a1 = A{1};
y=a1(:,:,3);
y(1,1);

for x = 1:88
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

Tt=sum(TOt)
T_1 = sum(Tt)
T_avg = T_1/88;

A = 1:2;          % matrix to draw
colormap([0, 0, .05
    0, 0, 0.1
    0, 0, 0.15
    0, 0, 0.2
    0, 0, 0.25
    0, 0, 0.3
    0, 0, 0.35
    0, 0, 0.4
    0, 0, 0.45
    0, 0, 0.5
    0, 0, 0.55
    0, 0, 0.6
    0, 0, 0.65
    0, 0, 0.7
    0, 0, 0.75
    0, 0, 0.8
    0, 0, 0.85
    0, 0, 0.9
    0, 0, 0.95
    0, 0, 1.0]);   % set colormap
imagesc(TOt/T_avg);        % draw image and scale colormap to values range
colorbar;          % show color scale