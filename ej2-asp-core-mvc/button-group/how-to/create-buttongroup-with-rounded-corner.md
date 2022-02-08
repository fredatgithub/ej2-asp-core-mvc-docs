---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Create Buttongroup With Rounded Corner of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Create Buttongroup With Rounded Corner
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create ButtonGroup with rounded corner

The ButtonGroup with rounded corner has round edges on both sided. To ButtonGroup with rounded corner, `e-round-corner` class is to be
added to the target element.

The following example illustrates how to create ButtonGroup with rounded corner.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/round/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/round/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/round/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/round/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
