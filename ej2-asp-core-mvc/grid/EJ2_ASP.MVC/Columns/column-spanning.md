---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Column Spanning of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Column Spanning
publishingplatform: ##Platform_Name##
documentation: ug
---

# Column Spanning

The grid has option to span the adjacent cells. You need to define the **colSpan** attribute to span cells in the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_QueryCellInfo) event.

In the following demo, employee **Davolio** is doing testing from 9.00 A.M. to 10.00 A.M. so that the cells have been spanned.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnspanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/columnspanning/columnspanning.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/columnspanning/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnspanning.cs" %}
{% include code-snippet/grid/columns/columnspanning/columnspanning.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
