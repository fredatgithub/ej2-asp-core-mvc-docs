---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Right To Left of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Right To Left
publishingplatform: ##Platform_Name##
documentation: ug
---

# Right-To-Left

Right To Left (RTL) can be enabled for Essential JS 2 components by calling `enableRtl` with
`true`. This will render all the Essential JS 2 components in right to left direction. Find the code snippet
for this below.

```html
<script>
    // Enables Right to left alignment for all controls
    ej.base.enableRtl(true);
</script>
```

## Enable RTL to individual component

To control a component’s direction individually you can directly set the component’s `enableRtl` property as true. For illustration, we have enabled RTL for Button component in following code snippet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}
