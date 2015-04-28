function xls2file(excelFile)
    [ndata,text]=xlsread(excelFile);
    [x,y]=size(text);
    clear ndata;
    clear y;
    FID=fopen('Excel2File.txt','w');
    for i=1:x 
        fprintf(FID,'%s/%s/%s/%s/%s\n',text{i,1},text{i,2},text{i,3},text{i,4},text{i,5});
        fprintf('%s/%s/%s/%s/%s\n',text{i,1},text{i,2},text{i,3},text{i,4},text{i,5});
    end
    fclose(FID);
    clear FID;
end