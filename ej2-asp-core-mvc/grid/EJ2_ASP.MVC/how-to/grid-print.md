---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grid Print of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grid Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add a title to the header when using Grid print action

You can add your title in the header through an [`BeforePrint`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~BeforePrint.html) event. With the help of this event you can add your title element as you want.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/titleprint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titleprint.cs" %}
{% include code-snippet/grid/how-to/titleprint/titleprint.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/titleprint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titleprint.cs" %}
{% include code-snippet/grid/how-to/titleprint/titleprint.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
