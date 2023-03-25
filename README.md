

# [treatz-app](https://github.com/johnedisc/treatz-app)

#### by [johnedisc](https://johnedisc.github.io/portfolio/)

#### An Epicodus project in making an asp.net mvc site with many-to-many database relationships and user authentication!

## technologies used

* C#
* ASP.NET 6
* entity framework
* Microsoft Identity for authentication and authorization
* mysql
* neovim text editor
* netcoredbg, samsung's open source dotnet debugger

## description

* this is an epicodus weekly project in the C# and .NET framework section of the course. it required making multiple classes and multiple controllers to route the content to different views with both attribute routing and html helpers. the site also employees many-to-many entities with the entity core framework object relational database.
* the stlying is accomplished using shared views to allow passing html snippets to different parts of the website and incorporates a simple css stylesheet
* the basic funtionality allows the authenticated user to view, create, update, delete their own pastry items. Users cannot see other users' pastry items and unauthenticated users cannot see any pastries at all

## setup/installation requirements

* [first install all the tools](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* open a terminal on your machine
* clone down the [repository from github](https://github.com/johnedisc/treatz-app) inside the directory of your choosing
```bash
git clone https://github.com/johnedisc/treatz-app
```
* move into the project directory (treatz-app/Treats)
```bash
cd HairSalon.Solution/Treats
```
* create appsettings.json file here. first edit [yourDatabaseName], [mysqlIdName], [yourPassword] to your own settings
```bash
printf '{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[yourDatabaseName];uid=[mysqlIdName];pwd=[yourPassword];"
  }
}' > appsettings.json
```
* install the dotnet ef tool
```bash
dotnet tool install --global dotnet-ef --version 6.0.0
```
* update the database 
```bash
dotnet ef database update
```
* run the application
```bash
dotnet watch run
```

## known Bugs

* no known bugs. layout is a work in progress.

## license

feel free to get in touch at [christopher(dot)johnedis(at)gmail(dot)com](christopher.johnedis@gmail.com)

MIT License

Copyright (c) [2023] [christopher johnedis]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


