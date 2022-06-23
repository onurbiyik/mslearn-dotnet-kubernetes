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