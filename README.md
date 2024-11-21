# console-project-example 
💻 A console project example using C# as programming language.

void LoadCity (String city)
		{
            DataSet ds = du.GetOffice(city);
            lblOutput.Text = "Here are the details for our " + city + " Office";
            dtlView.DataSource = ds.Tables[0];
            dtlView.DataBind();
		}

## About
An application about DOS, console, money exchange in examples and clients. All of these things together into a single app.

## Getting Started with jaya..........success
```bash
$> git clone https://github.com/cristianprochnow/console-project.git

$> cd console-project/

$> dotnet run
```
