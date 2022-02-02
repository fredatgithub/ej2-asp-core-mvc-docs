---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Collapse Grouped Rows At Initial Render of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Collapse Grouped Rows At Initial Render
publishingplatform: ##Platform_Name##
documentation: ug
---


# Collapse all grouped rows at initial render

You can collapse all the grouped rows at initial rendering by using `dataBound` event with  `collapseAll` method of the grid.

In the below demo, all the grouped rows are collapsed at initial rendering.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Collapseall.cs" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/collapseall.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Collapseall.cs" %}
{% include code-snippet/grid/how-to/collapse-grouped-rows/collapseall.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

