# StudentCRUDWinForm
An Ado.NET Windows Forms Application that Performs CRUD(Create,Read,Update,Delete).

## Installation

**To Begin**

- Simply Create a Databse in Microsoft SQL Server Management.
- After Creating a database with any name then Create a Table in that database and add 5 columns in that table. (**id[pkey,int],Name[varchar],Class[smallint],Section[varchar],Percentage[smallint],Gender[varchar]**)
- Insert values of your choice.
- In Databse Connection refer Form.cs file.
- Connection string = **"@Data Source = [ServerName]; Initial Catalog = [DatabseName]; Integrated Security = True;"**
- Run the project in Visual Studio

## Features

- **C**(_Create_)
- **R**(_Read_)
- **U**(_Update_)
- **D**(_Delete_)


### First Look
- _Fetching Values from Database after Clicking VIEW(**R**) button on DataGridView_ 
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img1.jpg)

- _Adding Values in the textbar input fields(**C**). After clicking on ADD button values will be added to the Database also._
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img2.jpg)

- _Shows a Message after successfully Inserting a value (MessageBox)._
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img3.jpg)

- _Can be seen the values is showing and added to the Database also._
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img4.jpg)

- _Performing Delete(**D**) Operation by clicking on DELETE buttton._
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img5.jpg)

- _Performing Update(**U**) Opertation by Double Clicking any specific row the values will automatically fetched into all textbox fields._
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img6.jpg)

- _Values Updated successfully after clicking on EDIT button._
![alt_text](https://github.com/VivekChoudhary77/StudentCRUDWinForm/blob/main/images/img7.jpg)
