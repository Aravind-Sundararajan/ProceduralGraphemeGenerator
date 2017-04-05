<html>

<head>
<style>
body {
    background-image: url("nebula2_02.gif");
}

div.img {
	
    margin: 10px;
    border: 1px solid #ccc;
    float: left;
    width: 45px;
}

div.img:hover {
    border: 1px solid #777;
}

div.img img {
    width: 100%;
    height: 45px;
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
<input type="submit">
</form>
</body>
</html>