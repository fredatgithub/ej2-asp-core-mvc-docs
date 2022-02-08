---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set Different Work Hours of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set Different Work Hours
publishingplatform: ##Platform_Name##
documentation: ug
---

# Set Different Working Hours on Different Days

By default, the work hours of the Scheduler is highlighted based on the start and end values provided within the `workHours` property which remains same for all days. To highlight different work hours range for different days,`setWorkHours` method can be used as follows.

`[src/app/app.ts]`

Now, run the application in the browser using the following command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/different-workhours/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/different-workhours/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/how-to/different-workhours/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/how-to/different-workhours/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
