---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Hide Dropdown Arrow of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Hide Dropdown Arrow
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hide dropdown arrow

You can hide the dropdown arrow from the DropDownButton by adding class `e-caret-hide`
to DropDownButton element using [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_CssClass)
property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/hide-arrow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hidearrow.cs" %}
{% include code-snippet/dropdownbutton/hide-arrow/hidearrow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/hide-arrow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hidearrow.cs" %}
{% include code-snippet/dropdownbutton/hide-arrow/hidearrow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
