let f = (function(){
    let person = {name:"Yan", age: 22};

    return {
        showName: function()
        {
            console.log(person.name);
        },

        showAge: function()
        {
            console.log(person.age)
        }
    }
})();

f.showAge();
f.showName();