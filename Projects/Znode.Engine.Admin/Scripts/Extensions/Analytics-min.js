gapi.analytics.ready(function(){gapi.analytics.auth.authorize({serverAuth:{access_token:$("#AnalyticsAccessToken").val()}});var r=new gapi.analytics.ext.ActiveUsers({container:"active-users-container",pollingInterval:5});r.once("success",function(){var s;this.on("change",function(a){var t=this.container.firstChild,e=0<a.delta?"is-increasing":"is-decreasing";t.className+=" "+e,clearTimeout(s),s=setTimeout(function(){t.className=t.className.replace(/ is-(increasing|decreasing)/g,"")},3e3)})}),new gapi.analytics.ext.ViewSelector2({container:"view-selector-container"}).execute().on("viewChange",function(a){var t,e,s,n,i;r.set(a).execute(),t=a.ids,new gapi.analytics.googleCharts.DataChart({query:{ids:t,"start-date":Constant.analyticsChartStartDate,"end-date":Constant.analyticsChartEndDate,metrics:"ga:users,ga:newUsers",dimensions:"ga:date"},chart:{container:"new-users-container",type:"LINE",options:{width:"100%"}}}).execute(),e=a.ids,new gapi.analytics.googleCharts.DataChart({query:{ids:e,"start-date":Constant.analyticsChartStartDate,"end-date":Constant.analyticsChartEndDate,metrics:"ga:bounceRate",dimensions:"ga:date"},chart:{container:"bounce-rate-container",type:"LINE",options:{width:"100%"}}}).execute(),s=a.ids,new gapi.analytics.googleCharts.DataChart({query:{ids:s,"start-date":Constant.analyticsChartStartDate,"end-date":Constant.analyticsChartEndDate,metrics:"ga:users,ga:newUsers",dimensions:"ga:keyword",sort:"-ga:keyword","max-results":Constant.analyticsTableChartMaxResults},chart:{container:"keywords-container",type:"TABLE",options:{width:"100%"}}}).execute(),n=a.ids,new gapi.analytics.googleCharts.DataChart({query:{ids:n,"start-date":Constant.analyticsChartStartDate,"end-date":Constant.analyticsChartEndDate,metrics:"ga:pageviews,ga:pageValue",dimensions:"ga:pagePath",sort:"-ga:pageviews","max-results":Constant.analyticsTableChartMaxResults},chart:{container:"page-views-container",type:"TABLE",options:{width:"100%"}}}).execute(),i=a.ids,new gapi.analytics.googleCharts.DataChart({query:{ids:i,"start-date":Constant.analyticsChartStartDate,"end-date":Constant.analyticsChartEndDate,metrics:"ga:users",dimensions:"ga:browser",sort:"-ga:users","max-results":Constant.analyticsTableChartMaxResults},chart:{container:"top-browsers-container",type:"TABLE",options:{width:"100%"}}}).execute()})});