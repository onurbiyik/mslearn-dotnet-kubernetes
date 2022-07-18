## update backend image
```
az acr build -r AGKESECR .\backend --resource-group AGKESE -t onur/backend
```

## update backend deployment
```
kubectl apply -f .\backend-deploy.yml -n pizza    
```


## update frontend deployment
```
kubectl apply -f .\frontend-deploy.yml -n pizza    
```




## Add Pod Disruption Budgets 
https://docs.microsoft.com/en-us/azure/aks/operator-best-practices-scheduler#plan-for-availability-using-pod-disruption-budgets
```
kubectl apply -f .\pdb.yml -n pizza    