---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Range Band of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Range Band
publishingplatform: ##Platform_Name##
documentation: ug
---


# Range Band

This section explains how to customize the sparkline with multiple range bands.

## Range band customization

The range band feature is used to highlight a particular range along with the y-axis using the [`startRange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~StartRange.html) and [`endRange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~EndRange.html) properties. You can also customize the [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~Color.html) and [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Charts.SparklineRangeBandSetting~Opacity.html) of the range band.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/rangeband/range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/sparkline/rangeband/range/range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/rangeband/range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range.cs" %}
{% include code-snippet/sparkline/rangeband/range/range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple range band customization

You can define multiple range bands to a sparkline as shown in the following code sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sparkline/rangeband/multi_range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multi_range.cs" %}
{% include code-snippet/sparkline/rangeband/multi_range/multi_range.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sparkline/rangeband/multi_range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multi_range.cs" %}
{% include code-snippet/sparkline/rangeband/multi_range/multi_range.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
