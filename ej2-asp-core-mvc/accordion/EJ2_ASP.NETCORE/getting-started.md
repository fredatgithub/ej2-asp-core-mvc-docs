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

 This section briefly explains about how to include a simple Accordion in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/) page for introduction part of the system requirements and configure the common specifications.

## Adding component to the Application

* Now open your view page to render Accordion component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/getting-started/data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/accordion/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/getting-started/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/accordion/getting-started/data/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Default accordion](../../accordion/images/accordion.PNG)

## Render the Accordion using content template

You can bind any data in Accordion items, by simply using the content template property in ASP.NET Accordion. Accordion is already provided with the content template support and hence we can utilize this support to load the other HTML elements or as per your requirement

In the below demo, the Accordion items are given with [chart](../../chart), [grid](../../grid), [calender](../../calendar) as their content using the content template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/accordion/getting-started/contenttemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Contenttemplate.cs" %}
{% include code-snippet/accordion/getting-started/contenttemplate/contenttemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/accordion/getting-started/contenttemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Contenttemplate.cs" %}
{% include code-snippet/accordion/getting-started/contenttemplate/contenttemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![content template](../../accordion/images/contenttemplate.PNG)

You can also render accordion without using `contentTemplate` which can be referred [here](../../accordion/how-to/set-the-nested-accordion).