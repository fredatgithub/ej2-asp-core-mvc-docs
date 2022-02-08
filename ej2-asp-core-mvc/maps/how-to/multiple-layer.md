---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Multiple Layer of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Multiple Layer
publishingplatform: ##Platform_Name##
documentation: ug
---

# Adding multiple layers in the Map

The multilayer support allows loading multiple shape files in a single container and enables Maps to display more information. The shape layer is the main layer of the Maps. Multiple layers can be added in a shape layer as **SubLayer** using the `Type` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/multilayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multilayer.cs" %}
{% include code-snippet/maps/multilayer/multilayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/multilayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multilayer.cs" %}
{% include code-snippet/maps/multilayer/multilayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Adding multiple layers in the Map](../images/How-to/multilayer.PNG)