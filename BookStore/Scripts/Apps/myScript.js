$(function () {
    /*
    ../Books - shows list of Books
    ../ Authors - shows list of Authors
    
    ../Books/Search - returns a JSON array of all books written by the given Author
        -This is a GET method
        -Input parameter is a string (Author name)
        -This method returns a JSON
    
    ../Books/DeleteByAuthor - returns a JSOn object showing count and status of books deleted 
    - This is a POST method
    - Input parameter is a string (Author name)
    -This method returns a JSON

    */

    $("#search").on("click", function () {
        var url = "/Books/Search";
        var searchstring = $("#AuthorSearch").val();

        $.get(url, { "s": searchstring }, function (data) {
            console.log(data);
            $("ul").remove();
            var ul = $("<ul></ul>").text("List of books by Author: " + searchstring);
            $("#results").append(ul);
            $.each(data, function (i, item) {
                var li = $("<li></li>").text(item.Id + " " + item.Title);
                ul.append(li);
            });
        });
    });
     
    $("#delete").on("click", function () {
        var url = "/Books/DeleteByAuthor";
        var searchstring = $("#AuthorSearch").val();

        $.post(url, { "s": searchstring }, function (data) {
            console.log(data);
            alert(data.count + "records deleted; Status: " + data.status);
        });
    });
    

});
