---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Content of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Content
publishingplatform: ##Platform_Name##
documentation: ug
---

# Displaying the HTML content

The HTML tags can be displayed in the Grid header and content by enabling the [`DisableHtmlEncode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DisableHtmlEncode) property in [`Column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/html/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/html/html.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/html/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/html/html.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
