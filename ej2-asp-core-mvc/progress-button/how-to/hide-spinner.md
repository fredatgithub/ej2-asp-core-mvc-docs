---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Hide Spinner of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Hide Spinner
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hide spinner

You can hide spinner in the ProgressButton by setting the `e-hide-spinner` property to [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.ProgressButton.html#Syncfusion_EJ2_SplitButtons_ProgressButton_CssClass).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-button/hide-spinner/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/hide-spinner/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-button/hide-spinner/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/progress-button/hide-spinner/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
