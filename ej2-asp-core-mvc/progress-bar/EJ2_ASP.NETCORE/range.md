---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Range of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Range
publishingplatform: ##Platform_Name##
documentation: ug
---


# Range

<!-- markdownlint-disable MD033 -->

Range represents the entire span of the progress bar and can be defined using the **minimum** and **maximum** properties. The default value of the range is 0 to 100.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
