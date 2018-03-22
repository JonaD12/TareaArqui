<?php 
 
 $num1 = POST_['distancia'];
 $num2 = POST_['tiempo'];

$result = $num1 / $num2;
echo "La velocidad es de: ".$result;

<script type="text /javascript">
function delayedRedirect()
{
	window.location.href = "index.php"
}
</script>
<body onload="setTimeout('delayedRedirect()', 5000)">
</body>
 ?>