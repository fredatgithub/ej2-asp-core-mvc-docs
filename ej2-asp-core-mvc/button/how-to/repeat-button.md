---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Repeat Button of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Repeat Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# Repeat Button

The Repeat button is a type of Button in that the click event is triggered at regular time interval from the pressed state
till the released state.

The following example explains about how to achieve Repeat Button in mouse and touch events.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button/howto/repeat-button/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Repeatbutton.cs" %}
{% include code-snippet/button/howto/repeat-button/repeatbutton.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button/howto/repeat-button/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Repeatbutton.cs" %}
{% include code-snippet/button/howto/repeat-button/repeatbutton.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
