# Dot Net Web Api Clean Architecture With CQRS Mediatr
Dot Net Web API Clean Architecture By using CQRS &amp; Mediator pattern 

1. Create Blank Solution
2. Create Folders in Blank Solution (src=> Common + Core + Infrastructure + Presentation )
3. In Presentation Folder create Folder (Apis +  Create a Web APi .net core with .net 8 Framwork in APis fodel  )
   ![image](https://github.com/user-attachments/assets/2d259638-e008-4325-9165-a1769368b62b)
4. Run the Application 1st in browser

# Api versioning .net core
API versioning is like labeling different editions of a book. It helps developers manage changes in an API over time. Here's why it's important, in simple terms:

1. **Avoid Breaking Things**: It prevents updates to an API from breaking old applications that rely on it.

2. **Smooth Updates**: New features can be added without disrupting users who are happy with the current setup.

3. **Easy Transitions**: Users can switch to a new version at their own pace when old features are being phased out.

4. **User Choice**: Users can pick the version that best suits their needs.

5. **Clear Organization**: Each version can have its own guide or instructions, making it easier for users to understand how to use it.

6. **Simplified Troubleshooting**: If there's a problem, it's easier to identify and fix issues specific to one version.

7. **Try New Things**: Developers can test new ideas in a specific version without affecting everyone.

8. **Enhanced Security**: Newer versions can have better security features, encouraging users to upgrade for improved protection.

Overall, API versioning helps keep everything organized and user-friendly as the API grows and improves.

**Implementation of Api Versioning in .net Core**
![image](https://github.com/user-attachments/assets/28b90ca9-f998-49be-85e9-fdb8996c3ab2)
as per the above image for example, as a backend API developer, you've created an API that is currently used by multiple clients. However, one client has requested some enhancements. Making changes to the API could impact all the clients using it. To avoid issues with all other clients, you'd like to ensure that any modifications don't disrupt their use of the existing API while accommodating the enhancement requests of the single client.

Here are a few potential solutions we have in mind:

1. **Notify Clients of Changes**: Implement the changes in the existing API and inform all clients so they can adjust on their end. However, this approach is not recommended as it may disrupt other clients.
2. **Specific Client Endpoint**: Provide a new endpoint tailored for the specific client's needs. While this addresses the individual client's request, it could lead to a change of endpoints, which is also not recommended.
3. **Versioning the API**: Create a new API endpoint with versioning, allowing clients to choose which version to use by adjusting the version parameter in the URL. This is the recommended approach as it provides flexibility and minimal disruption to the existing clients.

   
