# dapr-binding

In this repo, you can find the implementation of input binding by using dapr. I have used twitter to get its tweets into my app. Please follow the intructions:

1. Assuming that you already have Dapr at your local system. https://docs.dapr.io/getting-started/

2. Assuming that you have an app on your twitter's developer account. https://developer.twitter.com/en/apps

3. After clone, set the values of consumerKey, consumerSecret, accessToken and accessSecret in components/binding.yaml file from your app of twitter.

4. Now run the below command to start getting tweets into your app.
- dapr run -p 50000 -d ..\components\ -- dotnet run --urls http://*:50000

You will see that dapr will receive the tweets from twitter one by one and logging them.
