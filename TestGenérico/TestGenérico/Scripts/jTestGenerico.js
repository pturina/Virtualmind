class Employee {
    constructor(firstName, lastName, salary) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }
}


Employee.prototype.increase = function () {
    this.salary = this.salary + 1000;
};

Employee.prototype.display = function () {
    return "Name: " + this.firstName + " " + this.lastName + " - Salary: " + this.salary;
};


function MultiplyBy(a) {
    return function (b) {
        return function (c) {
            return a * b * c;
        };
    };
};



//function Longest_Country_Name(string) {
//    var str = string.split(",");
//    var longest = 0;
//    var word = null;
//    str.forEach(function (str) {
//        if (longest < str.length) {
//            longest = str.length;
//            word = str;
//        }
//    });
//    return word;
//}

function Longest_Country_Name(str) {
    var longest = 0;
    var word = null;
    str.forEach(function (str) {
        if (longest < str.length) {
            longest = str.length;
            word = str;
        }
    });
    document.write(word);
}


function removecolor() {
    var x = document.getElementById("colorSelect");
    x.remove(x.selectedIndex);
}

function insert_Row() {
    var table = document.getElementById('sampleTable');
    var count = table.rows.length;
    var row = table.insertRow(count);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    cell1.innerHTML = "Row" + (count + 1) + " cell1";
    cell2.innerHTML = "Row" + (count + 1) + " cell2";
}