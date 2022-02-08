---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to create a simple SplitButton in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add SplitButton to the project

To create SplitButton add the `ejs-splitbutton` tag with id attribute as `element` in your **Index.cshtml** page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



`ViewBag.items` variable is used for bounding the `items` property in view page.

## Bind dataSource

Populate the action items in `SplitButton` by using the `items` property. Here, the JSON values are passed to the
SplitButton control are generated in `HomeController.cs` and assigned to `ViewBag` variable.

```cs
public IActionResult Index()
    {
        // define the array of JSON
        List<object> items = new List<object>();
        items.Add(new
        {
            text = "Cut"
        });
        items.Add(new
        {
            text = "Copy"
        });
        items.Add(new
        {
            text = "Paste"
        });
        ViewBag.items = items;
        return View();
    }

```

Output be like the below.

![SplitButton Sample](./images/split-button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic SplitButton.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/split-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/split-button/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

