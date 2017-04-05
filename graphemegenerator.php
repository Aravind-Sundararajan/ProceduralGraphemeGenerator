<!DOCTYPE html>
<html>
<head>
<style>
body {
    background-image: url("nebula2_02.gif");
	text-align: center;
	}

div.img {
display: inline-block;
border: 1px solid #ccc;
width: 50px;
height: 50px;
margin: 0 auto;
}

div.img img {
	    
width: 50;
height: 50;
  
}

input[type=submit] {
    width: 100%;
    background-color: #9E99DA;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

input[type=submit]:hover {
    background-color: #827DB7;
}
</style>
</head>

<body>

<form action = "graphemegenerator.php" method="post">
<input id="slider1" type="range" min="4" max="32" step="1" name="x" />
<input id="slider2" type="range" min="4" max="32" step="1" name="y" />
<input id="slider3" type="range" min="0" max="100" step="1" name="fill" />
<input id="slider4" type="range" min="1" max="10" step="1" name="r1" />
<input id="slider5" type="range" min="1" max="10" step="1" name="r2" />
<input id="slider6" type="range" min="1" max="10" step="1" name="iteration" />
<input id="slider7" type="range" min="1" max="5000" step="1" name="seed" />
<input type="submit" name="SubmitButton" value="Generate!">
</form>


<?php 
//'C:\inetpub\wwwroot\New folder\cave_maker.exe 16 16 56 8 8 6 80')
//exec('C:\\inetpub\\wwwroot\\New folder\\cave_maker.exe 16 16 56 8 8 6 80');
//phpinfo()


if(isset($_POST['SubmitButton'])){
//exec('cave_maker.exe 16 16 56 8 8 6 80 2>&1', $output);
exec('cave_maker.exe '.strval($_POST["x"]) . ' ' . strval($_POST["y"]) . ' ' . strval($_POST["fill"]) . ' ' . strval($_POST["r1"]) . ' ' . strval($_POST["r2"]) . ' ' . strval($_POST["iteration"]) . ' ' . strval($_POST["seed"]) .' 2>&1', $output);
//print_r($output); 

exec('runner.bat 2>&1', $output);
//print_r($output); 
}
for( $i = 1; $i<11; $i++) {
for( $xi = 1; $xi<10; $xi++) {
//echo "Filename: " . str_pad(strval($i),3,"0", STR_PAD_LEFT) . ".bmp";
echo '<div class="img"> <img src="File' . str_pad(strval($i*$xi),3,"0", STR_PAD_LEFT) . '.bmp" width="50" height="50" '. rand(99,9999).'> </div>';
}
}
?>
</body>

</html>