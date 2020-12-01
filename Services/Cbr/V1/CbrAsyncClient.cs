using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using HuaweiCloud.SDK.Cbr.V1.Model;

namespace HuaweiCloud.SDK.Cbr.V1
{
    public partial class CbrAsyncClient : Client
    {
        public static ClientBuilder<CbrAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CbrAsyncClient>();
        }

        
        /// <summary>
        /// 添加备份成员
        /// </summary>
        public async Task<AddMemberResponse> AddMemberAsync(AddMemberRequest addMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , addMemberRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddMemberResponse>(response);
        }
        
        /// <summary>
        /// 添加资源
        /// </summary>
        public async Task<AddVaultResourceResponse> AddVaultResourceAsync(AddVaultResourceRequest addVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , addVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 设置存储库策略
        /// </summary>
        public async Task<AssociateVaultPolicyResponse> AssociateVaultPolicyAsync(AssociateVaultPolicyRequest associateVaultPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , associateVaultPolicyRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AssociateVaultPolicyResponse>(response);
        }
        
        /// <summary>
        /// 批量添加删除存储库资源标签
        /// </summary>
        public async Task<BatchCreateAndDeleteVaultTagsResponse> BatchCreateAndDeleteVaultTagsAsync(BatchCreateAndDeleteVaultTagsRequest batchCreateAndDeleteVaultTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>(response);
        }
        
        /// <summary>
        /// 复制备份
        /// </summary>
        public async Task<CopyBackupResponse> CopyBackupAsync(CopyBackupRequest copyBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , copyBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyBackupResponse>(response);
        }
        
        /// <summary>
        /// 复制备份还原点
        /// </summary>
        public async Task<CopyCheckpointResponse> CopyCheckpointAsync(CopyCheckpointRequest copyCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 创建备份还原点
        /// </summary>
        public async Task<CreateCheckpointResponse> CreateCheckpointAsync(CreateCheckpointRequest createCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 创建策略
        /// </summary>
        public async Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest createPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }
        
        /// <summary>
        /// 创建存储库
        /// </summary>
        public async Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest createVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVaultResponse>(response);
        }
        
        /// <summary>
        /// 添加存储库资源标签
        /// </summary>
        public async Task<CreateVaultTagsResponse> CreateVaultTagsAsync(CreateVaultTagsRequest createVaultTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , createVaultTagsRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateVaultTagsResponse>(response);
        }
        
        /// <summary>
        /// 删除备份
        /// </summary>
        public async Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest deleteBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackupResponse>(response);
        }
        
        /// <summary>
        /// 删除指定备份成员
        /// </summary>
        public async Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        /// <summary>
        /// 删除策略
        /// </summary>
        public async Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest deletePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deletePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }
        
        /// <summary>
        /// 删除存储库
        /// </summary>
        public async Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest deleteVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , deleteVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultResponse>(response);
        }
        
        /// <summary>
        /// 删除存储库资源标签
        /// </summary>
        public async Task<DeleteVaultTagResponse> DeleteVaultTagAsync(DeleteVaultTagRequest deleteVaultTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id" , deleteVaultTagRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, deleteVaultTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultTagResponse>(response);
        }
        
        /// <summary>
        /// 解除存储库策略
        /// </summary>
        public async Task<DisassociateVaultPolicyResponse> DisassociateVaultPolicyAsync(DisassociateVaultPolicyRequest disassociateVaultPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , disassociateVaultPolicyRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>(response);
        }
        
        /// <summary>
        /// 同步备份
        /// </summary>
        public async Task<ImportBackupResponse> ImportBackupAsync(ImportBackupRequest importBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportBackupResponse>(response);
        }
        
        /// <summary>
        /// 查询所有备份
        /// </summary>
        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest listBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listBackupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }
        
        /// <summary>
        /// 查询任务列表
        /// </summary>
        public async Task<ListOpLogsResponse> ListOpLogsAsync(ListOpLogsRequest listOpLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listOpLogsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListOpLogsResponse>(response);
        }
        
        /// <summary>
        /// 查询策略列表
        /// </summary>
        public async Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest listPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }
        
        /// <summary>
        /// 查询可保护资源
        /// </summary>
        public async Task<ListProtectableResponse> ListProtectableAsync(ListProtectableRequest listProtectableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type" , listProtectableRequest.ProtectableType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listProtectableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProtectableResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库列表
        /// </summary>
        public async Task<ListVaultResponse> ListVaultAsync(ListVaultRequest listVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, listVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVaultResponse>(response);
        }
        
        /// <summary>
        /// 迁移资源
        /// </summary>
        public async Task<MigrateVaultResourceResponse> MigrateVaultResourceAsync(MigrateVaultResourceRequest migrateVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , migrateVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<MigrateVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 移除资源
        /// </summary>
        public async Task<RemoveVaultResourceResponse> RemoveVaultResourceAsync(RemoveVaultResourceRequest removeVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , removeVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RemoveVaultResourceResponse>(response);
        }
        
        /// <summary>
        /// 备份恢复
        /// </summary>
        public async Task<RestoreBackupResponse> RestoreBackupAsync(RestoreBackupRequest restoreBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , restoreBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<RestoreBackupResponse>(response);
        }
        
        /// <summary>
        /// 查询指定备份
        /// </summary>
        public async Task<ShowBackupResponse> ShowBackupAsync(ShowBackupRequest showBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showBackupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupResponse>(response);
        }
        
        /// <summary>
        /// 查询备份还原点
        /// </summary>
        public async Task<ShowCheckpointResponse> ShowCheckpointAsync(ShowCheckpointRequest showCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id" , showCheckpointRequest.CheckpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showCheckpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCheckpointResponse>(response);
        }
        
        /// <summary>
        /// 获取备份成员详情
        /// </summary>
        public async Task<ShowMemberDetailResponse> ShowMemberDetailAsync(ShowMemberDetailRequest showMemberDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id" , showMemberDetailRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showMemberDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberDetailResponse>(response);
        }
        
        /// <summary>
        /// 获取备份成员列表
        /// </summary>
        public async Task<ShowMembersDetailResponse> ShowMembersDetailAsync(ShowMembersDetailRequest showMembersDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMembersDetailRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showMembersDetailRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMembersDetailResponse>(response);
        }
        
        /// <summary>
        /// 查询单个任务
        /// </summary>
        public async Task<ShowOpLogResponse> ShowOpLogAsync(ShowOpLogRequest showOpLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id" , showOpLogRequest.OperationLogId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showOpLogRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowOpLogResponse>(response);
        }
        
        /// <summary>
        /// 查询单个策略
        /// </summary>
        public async Task<ShowPolicyResponse> ShowPolicyAsync(ShowPolicyRequest showPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , showPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }
        
        /// <summary>
        /// 查询指定可保护资源
        /// </summary>
        public async Task<ShowProtectableResponse> ShowProtectableAsync(ShowProtectableRequest showProtectableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type" , showProtectableRequest.ProtectableType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showProtectableRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowProtectableResponse>(response);
        }
        
        /// <summary>
        /// 查询复制能力
        /// </summary>
        public async Task<ShowReplicationCapabilitiesResponse> ShowReplicationCapabilitiesAsync(ShowReplicationCapabilitiesRequest showReplicationCapabilitiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showReplicationCapabilitiesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>(response);
        }
        
        /// <summary>
        /// 查询指定存储库
        /// </summary>
        public async Task<ShowVaultResponse> ShowVaultAsync(ShowVaultRequest showVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , showVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库项目标签
        /// </summary>
        public async Task<ShowVaultProjectTagResponse> ShowVaultProjectTagAsync(ShowVaultProjectTagRequest showVaultProjectTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVaultProjectTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultProjectTagResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库资源实例
        /// </summary>
        public async Task<ShowVaultResourceInstancesResponse> ShowVaultResourceInstancesAsync(ShowVaultResourceInstancesRequest showVaultResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>(response);
        }
        
        /// <summary>
        /// 查询存储库资源标签
        /// </summary>
        public async Task<ShowVaultTagResponse> ShowVaultTagAsync(ShowVaultTagRequest showVaultTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , showVaultTagRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, showVaultTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultTagResponse>(response);
        }
        
        /// <summary>
        /// 更新备份成员状态
        /// </summary>
        public async Task<UpdateMemberStatusResponse> UpdateMemberStatusAsync(UpdateMemberStatusRequest updateMemberStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id" , updateMemberStatusRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberStatusResponse>(response);
        }
        
        /// <summary>
        /// 修改策略
        /// </summary>
        public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest updatePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , updatePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }
        
        /// <summary>
        /// 修改存储库
        /// </summary>
        public async Task<UpdateVaultResponse> UpdateVaultAsync(UpdateVaultRequest updateVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , updateVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVaultResponse>(response);
        }
        
    }
}