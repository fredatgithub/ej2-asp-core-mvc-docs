---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Select Items of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Select Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Select items to the list box

In the following example, `Bugatti Chiron` is selected using [`selectItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~SelectItems.html) method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/select-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Selectitem.cs" %}
{% include code-snippet/listbox/select-items/selectitem.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/select-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selectitem.cs" %}
{% include code-snippet/listbox/select-items/selectitem.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
