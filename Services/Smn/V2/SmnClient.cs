using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Smn.V2.Model;

namespace HuaweiCloud.SDK.Smn.V2
{
    public partial class SmnClient : Client
    {
        public static ClientBuilder<SmnClient> NewBuilder()
        {
            return new ClientBuilder<SmnClient>();
        }

        
        /// <summary>
        /// 订阅
        /// </summary>
        public AddSubscriptionResponse AddSubscription(AddSubscriptionRequest addSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , addSubscriptionRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 批量添加删除资源标签
        /// </summary>
        public BatchCreateOrDeleteResourceTagsResponse BatchCreateOrDeleteResourceTags(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchCreateOrDeleteResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchCreateOrDeleteResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>(response);
        }
        
        /// <summary>
        /// 取消订阅
        /// </summary>
        public CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_urn" , cancelSubscriptionRequest.SubscriptionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<CancelSubscriptionResponse>(response);
        }
        
        /// <summary>
        /// 创建消息模板
        /// </summary>
        public CreateMessageTemplateResponse CreateMessageTemplate(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMessageTemplateResponse>(response);
        }
        
        /// <summary>
        /// 添加资源标签
        /// </summary>
        public CreateResourceTagResponse CreateResourceTag(CreateResourceTagRequest createResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 创建主题
        /// </summary>
        public CreateTopicResponse CreateTopic(CreateTopicRequest createTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTopicResponse>(response);
        }
        
        /// <summary>
        /// 删除消息模板
        /// </summary>
        public DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , deleteMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteMessageTemplateResponse>(response);
        }
        
        /// <summary>
        /// 删除资源标签
        /// </summary>
        public DeleteResourceTagResponse DeleteResourceTag(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteResourceTagRequest.ResourceId.ToString());
            urlParam.Add("key" , deleteResourceTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagResponse>(response);
        }
        
        /// <summary>
        /// 删除主题
        /// </summary>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest deleteTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicResponse>(response);
        }
        
        /// <summary>
        /// 删除指定名称的主题策略
        /// </summary>
        public DeleteTopicAttributeByNameResponse DeleteTopicAttributeByName(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributeByNameRequest.TopicUrn.ToString());
            urlParam.Add("name" , deleteTopicAttributeByNameRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>(response);
        }
        
        /// <summary>
        /// 删除所有主题策略
        /// </summary>
        public DeleteTopicAttributesResponse DeleteTopicAttributes(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributesResponse>(response);
        }
        
        /// <summary>
        /// 查询消息模板详情
        /// </summary>
        public ListMessageTemplateDetailsResponse ListMessageTemplateDetails(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , listMessageTemplateDetailsRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询消息模板列表
        /// </summary>
        public ListMessageTemplatesResponse ListMessageTemplates(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplatesResponse>(response);
        }
        
        /// <summary>
        /// 查询项目标签
        /// </summary>
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listProjectTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询资源实例
        /// </summary>
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询资源标签
        /// </summary>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest listResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , listResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }
        
        /// <summary>
        /// 查询订阅者列表
        /// </summary>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }
        
        /// <summary>
        /// 查询指定Topic的订阅者列表
        /// </summary>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listSubscriptionsByTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>(response);
        }
        
        /// <summary>
        /// 查询主题策略
        /// </summary>
        public ListTopicAttributesResponse ListTopicAttributes(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopicAttributesResponse>(response);
        }
        
        /// <summary>
        /// 查询主题详情
        /// </summary>
        public ListTopicDetailsResponse ListTopicDetails(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicDetailsRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopicDetailsResponse>(response);
        }
        
        /// <summary>
        /// 查询主题列表
        /// </summary>
        public ListTopicsResponse ListTopics(ListTopicsRequest listTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopicsResponse>(response);
        }
        
        /// <summary>
        /// 查询SMN API V2版本信息
        /// </summary>
        public ListVersionResponse ListVersion(ListVersionRequest listVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , listVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVersionResponse>(response);
        }
        
        /// <summary>
        /// 查询SMN支持的API版本号信息
        /// </summary>
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        /// <summary>
        /// 消息发布
        /// </summary>
        public PublishMessageResponse PublishMessage(PublishMessageRequest publishMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , publishMessageRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PublishMessageResponse>(response);
        }
        
        /// <summary>
        /// 更新消息模板
        /// </summary>
        public UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , updateMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMessageTemplateResponse>(response);
        }
        
        /// <summary>
        /// 更新主题
        /// </summary>
        public UpdateTopicResponse UpdateTopic(UpdateTopicRequest updateTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicResponse>(response);
        }
        
        /// <summary>
        /// 更新主题策略
        /// </summary>
        public UpdateTopicAttributeResponse UpdateTopicAttribute(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicAttributeRequest.TopicUrn.ToString());
            urlParam.Add("name" , updateTopicAttributeRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicAttributeResponse>(response);
        }
        
        /// <summary>
        /// 创建Application
        /// </summary>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationResponse>(response);
        }
        
        /// <summary>
        /// 删除Application
        /// </summary>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , deleteApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }
        
        /// <summary>
        /// 查询Application属性
        /// </summary>
        public ListApplicationAttributesResponse ListApplicationAttributes(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationAttributesRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationAttributesResponse>(response);
        }
        
        /// <summary>
        /// 查询Application
        /// </summary>
        public ListApplicationsResponse ListApplications(ListApplicationsRequest listApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }
        
        /// <summary>
        /// App消息发布
        /// </summary>
        public PublishAppMessageResponse PublishAppMessage(PublishAppMessageRequest publishAppMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , publishAppMessageRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PublishAppMessageResponse>(response);
        }
        
        /// <summary>
        /// 更新Application
        /// </summary>
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , updateApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }
        
        /// <summary>
        /// 创建Application endpoint
        /// </summary>
        public CreateApplicationEndpointResponse CreateApplicationEndpoint(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , createApplicationEndpointRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationEndpointResponse>(response);
        }
        
        /// <summary>
        /// 删除Application endpoint
        /// </summary>
        public DeleteApplicationEndpointResponse DeleteApplicationEndpoint(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , deleteApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>(response);
        }
        
        /// <summary>
        /// 查询Application的Endpoint属性
        /// </summary>
        public ListApplicationEndpointAttributesResponse ListApplicationEndpointAttributes(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , listApplicationEndpointAttributesRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>(response);
        }
        
        /// <summary>
        /// 查询Application的Endpoint列表
        /// </summary>
        public ListApplicationEndpointsResponse ListApplicationEndpoints(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationEndpointsRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointsResponse>(response);
        }
        
        /// <summary>
        /// 更新Application endpoint
        /// </summary>
        public UpdateApplicationEndpointResponse UpdateApplicationEndpoint(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , updateApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>(response);
        }
        
    }
}