function hidePass() {
    var x = document.getElementById("password_input");
    if (x.type === "password") {
      x.type = "text";
    } else {
      x.type = "password";
    }
  }


