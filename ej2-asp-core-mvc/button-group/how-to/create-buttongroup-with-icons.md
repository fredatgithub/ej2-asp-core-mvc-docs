---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Create Buttongroup With Icons of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Create Buttongroup With Icons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Create ButtonGroup with icons

ButtonGroup with icons can be achieved by `IconCss` property of the Button component.

The following example illustrates how to create ButtonGroup with icons.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/icon/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/icon/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/icon/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/icon/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
