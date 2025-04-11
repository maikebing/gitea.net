// The MIT License (MIT)
//
// gitea.net (https://github.com/mkloubert/gitea.net)
// Copyright (c) Marcel Joachim Kloubert <marcel.kloubert@gmx.net>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER


/*****************************************************************************
 * CREATE A CLASS 'Credentials' in the namespace 'Gitea.API.Sandbox'         *
 *                                                                           *
 * s. below RunAsync()                                                       *
 ****************************************************************************/


using Gitea.API.v1;


 


            using (var client = new Client("maikebing", "58a42dbc446a85af6ba547dd800e0c07e8c020bd", "gitea.com",80,true))
{
    var version = await client.GetVersion();
    if (version != null)
    {

    }

    /* var newUser = await client.Users.New()
        .Email("marcel.kloubert@gmx.net")
        .UserName("kloubi")
        .Password("P@assword123!")
        .FullName("Houbi The Kloubi")
        .SendNotification()
        .Create();


    var kloubi = await client.Users.GetByUsername("kloubi");
    kloubi = await kloubi.Update()
        .Email("marcel.kloubert@gmx.net")
        .Password("A_New_P@ssword_123 !")
        .FullName("The Kloubi")
        .IsActive(false)
        .MakeAdmin()
        .Location("Aachen")
        .NoRepositoryCreationLimit()
        .Save();

    await kloubi.Delete();
    */

    var user = await client.Users.GetCurrent();
    if (user != null)
    {
        var r = await user.Repositories.Create().Name("test1111").Description("afsddfa").MakePrivate(true)
            .MakeAutoInit(false).Start();

    }
}

