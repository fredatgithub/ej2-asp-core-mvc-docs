---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Select Grid Rows Based On Certain Condition of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Select Grid Rows Based On Certain Condition
publishingplatform: ##Platform_Name##
documentation: ug
---


# Select grid rows based on certain condition

You can select the specific row in the grid based on a certain condition by using the `selectRows` method in the `dataBound` event of Grid.

In the below demo, we have selected the grid rows only when `EmployeeID` column value greater than `3`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/databasedselection/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databasedselection.cs" %}
{% include code-snippet/grid/how-to/databasedselection/databasedselection.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/databasedselection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databasedselection.cs" %}
{% include code-snippet/grid/how-to/databasedselection/databasedselection.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

