function varargout = procedural_letter_gen(varargin)

% PROCEDURAL_LETTER_GEN MATLAB code for procedural_letter_gen.fig
%      PROCEDURAL_LETTER_GEN, by itself, creates a new PROCEDURAL_LETTER_GEN or raises the existing
%      singleton*.
%
%      H = PROCEDURAL_LETTER_GEN returns the handle to a new PROCEDURAL_LETTER_GEN or the handle to
%      the existing singleton*.
%
%      PROCEDURAL_LETTER_GEN('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in PROCEDURAL_LETTER_GEN.M with the given input arguments.
%
%      PROCEDURAL_LETTER_GEN('Property','Value',...) creates a new PROCEDURAL_LETTER_GEN or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before procedural_letter_gen_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to procedural_letter_gen_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help procedural_letter_gen

% Last Modified by GUIDE v2.5 26-Apr-2015 09:58:25

% Begin initialization code - DO NOT EDIT

gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @procedural_letter_gen_OpeningFcn, ...
                   'gui_OutputFcn',  @procedural_letter_gen_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before procedural_letter_gen is made visible.
function procedural_letter_gen_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to procedural_letter_gen (see VARARGIN)

% Choose default command line output for procedural_letter_gen
handles.output = hObject;
j=1; 
for i = 132:219    
 axes(handles.(sprintf('axes%d', i)));
    if j <10 
    filename = sprintf('entry00%d.png', j)
    A{i} = imread(filename);
    elseif j <100 
    filename = sprintf('entry0%d.png', j)
    A{i} = imread(filename);
    else 
    filename = sprintf('entry%d.png', j)
    A{i} = imread(filename);
    end
    j=j+1;
 imshow(A{i});
 end
% Update handles structure
guidata(hObject, handles);

% UIWAIT makes procedural_letter_gen wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = procedural_letter_gen_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;


% --- Executes on button press in pushbutton1.
function pushbutton1_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

 
seed1 = get(handles.edit1,'String');
inpt = sprintf('cave_maker.exe 16 16 56 8 8 6 %s',seed1);
system(inpt);
seed = str2num(seed1);

 for i = 1:88
 axes(handles.(sprintf('axes%d', i)));
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
 imshow(A{i});
 end
 system('runner.bat');
 
 
%axes(handles.(sprintf('axes%d', i)));
figure;
%subplot(1,2,1);
letter_analysis();
%subplot(1,2,2);
%letter_analysis_std();


 

function edit1_Callback(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of edit1 as text
%        str2double(get(hObject,'String')) returns contents of edit1 as a double


% --- Executes during object creation, after setting all properties.
function edit1_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on button press in pushbutton5.
function pushbutton5_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton5 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
system('fontinst.bat');
set(handles.text55,'FontName','Untitled1');


% --- Executes on button press in pushbutton6.
function pushbutton6_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
system('fontinst.bat');
 set(handles.text55,'FontName','Untitled1');


% --- Executes on button press in pushbutton7.
function pushbutton7_Callback(hObject, eventdata, handles)
% hObject    handle to pushbutton7 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


