<?php

include("db.php");
$db = new Database();

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $email = $_POST["email"];
    $password = $_POST["password"];

    $sql = "INSERT INTO users (email, password) VALUES (?, ?)";
    $stmt = $db->pdo->prepare($sql);

    try {
        $stmt->execute([$email, $password]);
        echo "Data inserted successfully!";
    } catch (PDOException $e) {
        echo "Error: " . $e->getMessage();
    }
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="" method="post">

        <input type="email" name="email" id="" required>
        <input type="password" name="password" id="" required>
        <input type="submit" value="Submit">

    </form>
</body>

</html>