---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Legend Label Customization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Legend Label Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change the legend label text

You can change the legend label using the `LegendRender` client-side event. You can also hide the legend label using this client-side event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/heatmap/how-to/legend/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/how-to/legend/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/heatmap/how-to/legend/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/heatmap/how-to/legend/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
