# UbiWork
TestWork

I have Created a Async API.
Created local "SQL DB EXPRESS" and used Code First approach in Entity Framework6(ORM).

There is two API in one is Get and another one is post.
1. GET: Host:port/api/Score
2. POST: Host:port/api/Score
   FormBody:
   [{
	"ScoreId":123,
	"Score":12.00
	
},
{
	"ScoreId":124,
	"Score":14.20
	
}]


I have used Basic Authentation
UserId:susovan
Password:das

Step To Publish in AWS:
Step 1: Create the Publish file from Visual Studio.
Step 2: Create IAM role for EC2 instances.
Step 3: Create New EC2 instances for hosting publish site.
Step 4: Create config to EC2 instances for Auto Scaling.
Step 5: Create ELB to check the health of the EC2 and give notification to the user.



