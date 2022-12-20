var form = document.getElementById("form");

form.addEventListener("submit", function (event) {
  event.preventDefault();

  if (firstName()) {
    if (lastName()) {
      if (emailCheck()) {
        if (phone()) {
          open("Calculator.html", "_self");
        }
      }
    }
  }
});

function firstName() {
  var fname = document.getElementById("fname");
  if (/^[A-Za-z\s]+$/.test(fname.value)) {
    return true;
  } else {
    alert("Invalid first name");
    return false;
  }
}

function lastName() {
  var lname = document.getElementById("lname");
  if (/^[A-Za-z\s]+$/.test(lname.value)) {
    return true;
  } else {
    alert("Invalid last name");
    return false;
  }
}

function emailCheck() {
  var email = document.getElementById("email");
  if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email.value)) {
    return true;
  } else {
    alert("Plese enter valid email");
    return false;
  }
}

function phone() {
  var phone = document.getElementById("phone");
  if (/^\d{10}$/.test(phone.value)) {
    return true;
  } else {
    alert("Invalid phone number");
    return false;
  }
}
