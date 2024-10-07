<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>¡Resultados de datos!</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="dive2">
       <h1>Resultados</h1>
       <center><img src="img/umi.png" alt="Felicidades"> </center>   
       <h2>Bien hecho</h2>

        <?php
            $name = $_POST['Name'];
            $age = $_POST['Age'];
            $city = $_POST['City'];
            $birthday = $_POST['Birthday'];
            $hobby = $_POST['Hobby'];    

            echo '<p><b>Nombre:</b> '.$name.' </p>';
            echo '<p><b>Edad:</b> '.$age.' </p>';
            echo '<p><b>Ciudad:</b> '.$city.' </p>';
            echo '<p><b>Fecha de nacimiento:</b> '.$birthday.' </p>';
            echo '<p><b>Hobby:</b> '.$hobby.' </p>';
        ?>

       <div id="popUpoverlay"> </div>
       <div id="popUpBox"> 
          <div id="Box">
              <i class="fas fa-question-circle fa-5x"></i>
              <center><h1>¿Volver a ingresar datos?</h1><center>
              <div id="closeModal"></div>

          </div>
        
       </div> 
       <br>
       <center><button onclick="Alert.render('Tú te miras muy bien hoy')" class="btn">¡Volver a ingresar!</button><center>
           <script src="JS/app.js"></script>
    </div>
</body>
</html>