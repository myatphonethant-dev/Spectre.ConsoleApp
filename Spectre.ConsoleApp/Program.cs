using Spectre.Console;

#region Color

//Console.WriteLine();
//AnsiConsole.Markup("[underline red]Hello[/] World!");

//Console.WriteLine();
//var table = new Table();
//table.AddColumn(new TableColumn(new Markup("[yellow]Foo[/]")));
//table.AddColumn(new TableColumn("[blue]Bar[/]"));
//AnsiConsole.Write(table);

//Console.WriteLine();
//AnsiConsole.Markup("[underline green]Hello[/] ");
//AnsiConsole.MarkupLine("[bold]World[/]");

//Console.WriteLine();
//AnsiConsole.Markup("[[Hello]] "); // [Hello]
//AnsiConsole.Markup("[red][[World]][/]"); // [World]

//Console.WriteLine();
//AnsiConsole.Markup("[red]{0}[/]", "Hello [World]".EscapeMarkup());

//Console.WriteLine();
//AnsiConsole.Markup("[red]{0}[/]", Markup.Escape("Hello [World]"));

//Console.WriteLine();
//string hello = "Hello [World]";
//AnsiConsole.MarkupInterpolated($"[red]{hello}[/]");

//Console.WriteLine();
//AnsiConsole.Markup("[bold yellow on blue]Hello[/]");
//AnsiConsole.Markup("[default on blue]World[/]");

//Console.WriteLine();
//AnsiConsole.Markup("Hello :smile:!");

//Console.WriteLine();
//AnsiConsole.Markup("[link]https://spectreconsole.net[/]");
//AnsiConsole.Markup("[link=https://spectreconsole.net]Spectre Console Documentation[/]");

#endregion

#region Exception

//try
//{
//    int value1 = 2;
//    int value2 = 3;

//    var value = value1 + value2;

//    if (value == 5)
//        throw new Exception();
//}
//catch (Exception ex)
//{
//    AnsiConsole.WriteException(ex);
//}

#endregion

#region Live Table

//var table = new Table().Centered();

//AnsiConsole.Live(table)
//    .Start(ctx =>
//    {
//        table.AddColumn("BlogId");
//        ctx.Refresh();
//        Thread.Sleep(1000);

//        table.AddColumn("BlogTitle");
//        ctx.Refresh();
//        Thread.Sleep(1000);

//        table.AddColumn("BlogAuthor");
//        ctx.Refresh();
//        Thread.Sleep(1000);

//        table.AddColumn("BlogContent");
//        ctx.Refresh();
//        Thread.Sleep(1000);
//    });

//var table = new Table().Centered();

//await AnsiConsole.Live(table)
//    .StartAsync(async ctx =>
//    {
//        table.AddColumn("BlogId");
//        ctx.Refresh();
//        await Task.Delay(1000);

//        table.AddColumn("BlogTitle");
//        ctx.Refresh();
//        await Task.Delay(1000);

//        table.AddColumn("BlogAuthor");
//        ctx.Refresh();
//        await Task.Delay(1000);

//        table.AddColumn("BlogContent");
//        ctx.Refresh();
//        await Task.Delay(1000);
//    });

//var table = new Table().Centered();

//AnsiConsole.Live(table)
//    .AutoClear(false)   // Do not remove when done
//    .Overflow(VerticalOverflow.Ellipsis) // Show ellipsis when overflowing
//    .Cropping(VerticalOverflowCropping.Top) // Crop overflow at top
//    .Start(ctx =>
//    {
//        // Omitted
//    });

//AnsiConsole.Progress()
//    .Start(ctx =>
//    {
//        // Define tasks
//        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
//        var task2 = ctx.AddTask("[green]Folding space[/]");

//        while (!ctx.IsFinished)
//        {
//            task1.Increment(1.5);
//            task2.Increment(0.5);
//        }
//    });

//await AnsiConsole.Progress()
//    .StartAsync(async ctx =>
//    {
//        // Define tasks
//        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
//        var task2 = ctx.AddTask("[green]Folding space[/]");

//        while (!ctx.IsFinished)
//        {
//            // Simulate some work
//            await Task.Delay(250);

//            // Increment
//            task1.Increment(1.5);
//            task2.Increment(0.5);
//        }
//    });

//AnsiConsole.Progress()
//    .AutoRefresh(false) // Turn off auto refresh
//    .AutoClear(false)   // Do not remove the task list when done
//    .HideCompleted(false)   // Hide tasks as they are completed
//    .Columns(new ProgressColumn[]
//    {
//        new TaskDescriptionColumn(),    // Task description
//        new ProgressBarColumn(),        // Progress bar
//        new PercentageColumn(),         // Percentage
//        new RemainingTimeColumn(),      // Remaining time
//        new SpinnerColumn(),            // Spinner
//    })
//    .Start(ctx =>
//    {
//        var task1 = ctx.AddTask("[green]Reticulating splines[/]");
//        var task2 = ctx.AddTask("[green]Folding space[/]");

//        while (!ctx.IsFinished)
//        {
//            task1.Increment(1.5);
//            task2.Increment(0.5);
//        }
//    });

#endregion

#region Status

//AnsiConsole.Status()
//    .Start("Thinking...", ctx =>
//    {
//        // Simulate some work
//        AnsiConsole.MarkupLine("Doing some work...");
//        Thread.Sleep(1000);

//        // Update the status and spinner
//        ctx.Status("Thinking some more");
//        ctx.Spinner(Spinner.Known.Star);
//        ctx.SpinnerStyle(Style.Parse("green"));

//        // Simulate some work
//        AnsiConsole.MarkupLine("Doing some more work...");
//        Thread.Sleep(2000);
//    });

//await AnsiConsole.Status()
//    .StartAsync("Thinking...", async ctx =>
//    {
//        AnsiConsole.MarkupLine("Doing some work...");
//        Thread.Sleep(1000);

//        ctx.Status("Thinking some more");
//        ctx.Spinner(Spinner.Known.Star);
//        ctx.SpinnerStyle(Style.Parse("green"));

//        AnsiConsole.MarkupLine("Doing some more work...");
//        Thread.Sleep(2000);
//    });

//AnsiConsole.Status()
//    .AutoRefresh(false)
//    .Spinner(Spinner.Known.Star)
//    .SpinnerStyle(Style.Parse("green bold"))
//    .Start("Thinking...", ctx =>
//    {
//        AnsiConsole.MarkupLine("Doing some work...");
//        Thread.Sleep(1000);

//        ctx.Status("Thinking some more");
//        ctx.Spinner(Spinner.Known.Star);
//        ctx.SpinnerStyle(Style.Parse("green"));

//        AnsiConsole.MarkupLine("Doing some more work...");
//        ctx.Refresh();
//    });

#endregion

Console.ReadLine();
