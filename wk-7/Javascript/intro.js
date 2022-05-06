    // Now that I'm inside the script tags I am using javascript.
            // This is a commit.

            // Javascript is UNRELATED to JAVA!

            // In JS, we can use numbers!
            let x = 5; // remember in JS to usel as you end thought/section/action character.
            // let is one way that is another way to declare a variable.
            
            let y = 7; // var is another way to declare a variable
            let z = Infinity;

            x = 3 * 6;
            y = 1 / 0; // w ecan actually get infinity values from a calculation!
            z= NaN; // this is a special value that represents a variable/object that is not a number.
            z = 'asdf' - 5; // this results in NaN.

            // Boolean operators

            x = 3 == 3; // "== " is the euqality operator, it checks if the values are equal.


            // Strings
            x = 'hello'; // this is a string
            y = "hello"; // this is also a string
            z = 'as"df\"';

            // JS can perform template literal (string interpolation)
            x = `4 + 4 == ${4 + 4}`;

            // JS can accept multi-line strings! Use "back-tick" (under the ~)
            x = `asf
            asdf
            asdf`;

            //Console.Log();
            //The console of your browser is where you can see the output of your 
            console.log('Hello World!');
            console.log(x);

            // Object in JS

            x = {}; //this is an object literal
            console.log(x);
            x.name = 'Fred'; // this is how you dd a property to an object
            
            console.log(x);
            delete x.name(); // this is how you delete a propery from an object
            console.log(x);

            x = {
                name: 'Fred',
                'properties can have space in their names': 5,
                3: 5
            };
            console.log(x);
            console.log(x.name);
            console.log(x[3]);
            console.log(x[`properties can have spaces in their names`]);
            x[`name of`] = "Kevin";
            console.log(x[`name of`]);
            x.newProperty = "Kevin";
            console.log(x.newProperty);

            // Undefined
            // special datatype with only one possibl value, undefined.
            // if you don't pass something for a function parameter, it will be undefined.
            // if you don't return a value from a function, it will be undefined.

            x = undefined;

            // Null
            // special data type with only one possible value, null.
            // null represents missing data.
            // type of says null is an object, wrongly.

            x = null;
            console.log(x);
            console.log(typeof x);

            // funcions.
            //functions are ofobject type, but typeof calls them functions. (for historical reasons)
            x = function () 
            {
                console.log(`hello`);
            }
            x();
            // functions can accept and return data similar to how we are familiar in C#.
            x = () =>{
                console.log(`Hi there!`);
            }
            x();

            x = a => a + a;

            console.log( x(2,2));
            console.log( x("hi"));