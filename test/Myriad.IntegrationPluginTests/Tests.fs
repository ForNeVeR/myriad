module Tests

open System
open Expecto
open Example

let tests =
    testList "basic tests" [

        test "Test namespace generated" {
            Expect.equal Test.example1.fourtyTwo 42 "generated value should be 42"
        }

        test "Test2 namespace generated" {
            Expect.equal Test2.example1.fourtyTwo 42 "generated value should be 42"
        }

        test "Test1 create Test" {
            let t = Test.Test1.create 1 "2" 3. (float32 4)
            Expect.equal t {Test1.one = 1; two = "2"; three = 3.; four = float32 4 } "generated records should be ok"
        }

        test "Test2 create Test" {
            let t = Test2.Test1.create 1 "2" 3. (float32 4)
            Expect.equal t {Test1.one = 1; two = "2"; three = 3.; four = float32 4 } "generated records should be ok"
        }

        test "Test1 accessor Test" {
            let t = Test.Test1.create 1 "2" 3. (float32 4)
            let z = Test.Test1.one t
            Expect.equal z 1 "generated getters should be ok"
        }

        test "Test2 accessor Test" {
            let t = Test2.Test1.create 1 "2" 3. (float32 4)
            let z = Test2.Test1.one t
            Expect.equal z 1 "generated getters should be ok"
        }


    ]